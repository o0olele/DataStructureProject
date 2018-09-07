using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace T
{
    /// <summary>
    /// 地铁线路图类。
    /// </summary>
    public class MetroGraph
    {
        #region 字段区域

        private MetroLineCollection m_lines = new MetroLineCollection();
        private MetroNodeCollection m_nodes = new MetroNodeCollection();

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取地铁线路的集合。该属性始终不为空引用。
        /// </summary>
        public MetroLineCollection Lines
        {
            get { return m_lines; }
        }

        /// <summary>
        /// 获取地铁站点的集合。该属性始终不为空引用。
        /// </summary>
        public MetroNodeCollection Nodes
        {
            get { return m_nodes; }
        }

        /// <summary>
        /// 获取地铁路径的枚举迭代。该属性始终不为空引用。
        /// </summary>
        public IEnumerable<MetroLink> Links
        {
            get
            {
                foreach (var node in this.Nodes)
                {
                    foreach (var link in node.Links)
                    {
                        yield return link;
                    }
                }
            }
        }

        #endregion

        #region 方法区域

        /// <summary>
        /// 获取指定两个线路的中转站。
        /// </summary>
        /// <param name="line1">线路1。</param>
        /// <param name="line2">线路2。</param>
        /// <returns>中转站。</returns>
        /// <exception cref="ArgumentNullException">如果line1或line2为空引用，则抛出该异常。</exception>
        public IEnumerable<MetroNode> GetTransferNodes(MetroLine line1, MetroLine line2)
        {
            if (line1 == null) throw new ArgumentNullException("line1");
            if (line2 == null) throw new ArgumentNullException("line2");
            if (line1 == line2) yield break;

            foreach (var node in this.Nodes.Where(c => c.Links.Count > 2
               && c.Links.Exists(k => k.Line == line1) && c.Links.Exists(k => k.Line == line2)))
            {
                yield return node;
            }
        }

        #endregion
    }

    /// <summary>
    /// 地铁线路类。例如：1号线、2号线。
    /// </summary>
    public class MetroLine
    {
        #region 字段区域

        private string m_name = string.Empty;
        private Color m_color = Color.Black;

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取或设置线路的名称。
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// 获取或设置线路的颜色。
        /// </summary>
        public Color Color
        {
            get { return m_color; }
            set { m_color = value; }
        }

        #endregion

        #region 方法区域

        /// <summary>
        /// 返回当前对象的字符串表示。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }

    /// <summary>
    /// 地铁线路集合类。
    /// </summary>
    public class MetroLineCollection : KeyedCollection<string, MetroLine>
    {
        #region 方法区域

        /// <summary>
        /// 获取集合元素的唯一键。
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        protected override string GetKeyForItem(MetroLine item)
        {
            return item.Name;
        }

        #endregion
    }

    /// <summary>
    /// 地铁路径类。
    /// 该类表示两个站点之间的行车路径。
    /// 路径是双向的，如果有A->B，一定有一条B->A。
    /// </summary>
    public class MetroLink
    {
        #region 构造区域

        /// <summary>
        /// 构造函数。
        /// </summary>
        /// <param name="line">所属线路。</param>
        /// <param name="from">来源站点。</param>
        /// <param name="to">目标站点。</param>
        /// <exception cref="ArgumentNullException">如果from或to为空引用，则抛出该异常。</exception>
        public MetroLink(MetroLine line, MetroNode from, MetroNode to)
        {
            if (line == null) throw new ArgumentNullException("line");
            if (from == null) throw new ArgumentNullException("from");
            if (to == null) throw new ArgumentNullException("to");

            m_line = line;
            m_from = from;
            m_to = to;
        }

        #endregion

        #region 字段区域

        private MetroNode m_from;
        private MetroNode m_to;
        private MetroLine m_line;
        private float m_weight;
        private int m_flag;

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取所属线路。该属性始终不为空引用。
        /// </summary>
        public MetroLine Line
        {
            get { return m_line; }
        }

        /// <summary>
        /// 获取来源站点。该属性始终不为空引用。
        /// </summary>
        public MetroNode From
        {
            get { return m_from; }
        }

        /// <summary>
        /// 获取目标站点。该属性始终不为空引用。
        /// </summary>
        public MetroNode To
        {
            get { return m_to; }
        }

        /// <summary>
        /// 获取或设置权重（运行时长，单位：分钟）。
        /// </summary>
        public float Weight
        {
            get { return m_weight; }
            set { m_weight = value; }
        }

        /// <summary>
        /// 获取或设置内部标识。
        /// 0表示无并轨；1表示第一条线路；2表示第二条线路；-1表示反向路径，不与绘制。
        /// </summary>
        public int Flag
        {
            get { return m_flag; }
            set { m_flag = value; }
        }

        #endregion

        #region 方法区域

        /// <summary>
        /// 返回当前对象的字符串表示。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0}:{1}->{2}", this.Line.Name, this.From.Name, this.To.Name);
        }

        #endregion
    }

    /// <summary>
    /// 地铁站点类。例如：南京西路、世纪公园。
    /// </summary>
    public class MetroNode
    {
        #region 字段区域

        private string m_name = string.Empty;
        private int m_x;
        private int m_y;
        private List<MetroLink> m_links = new List<MetroLink>();

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取或设置站点名称。
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// 获取或设置站点的X坐标。
        /// </summary>
        public int X
        {
            get { return m_x; }
            set { m_x = value; }
        }

        /// <summary>
        /// 获取或设置站点的Y坐标。
        /// </summary>
        public int Y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        /// <summary>
        /// 获取从该站点出发的路径集合。该属性始终不为空引用。
        /// </summary>
        public List<MetroLink> Links
        {
            get { return m_links; }
        }

        #endregion

        #region 方法区域

        /// <summary>
        /// 返回当前对象的字符串表示。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Name;
        }

        #endregion
    }

    /// <summary>
    /// 地铁站点集合类。
    /// </summary>
    public class MetroNodeCollection : KeyedCollection<string, MetroNode>
    {
        #region 方法区域

        /// <summary>
        /// 获取集合元素的唯一键。
        /// </summary>
        protected override string GetKeyForItem(MetroNode item)
        {
            return item.Name;
        }

        #endregion
    }

    /// <summary>
    /// 乘车路线。
    /// 该类表示从一个站定到另一个站点的乘车路线。例如：南京西路->人民广场->南京东路。
    /// </summary>
    public sealed class MetroPath
    {
        #region 字段区域

        private List<MetroLink> m_links = new List<MetroLink>();

        #endregion

        #region 属性区域

        /// <summary>
        /// 获取路径列表。该属性始终不为空引用。
        /// </summary>
        public List<MetroLink> Links
        {
            get { return m_links; }
        }

        /// <summary>
        /// 获取换乘次数。
        /// </summary>
        public int Transfers
        {
            get
            {
                if (m_links.Count < 2) return 0;

                int count = 0;
                var line = Links[0].Line;
                for (int i = 1; i < Links.Count; i++)
                {
                    if (Links[i].Line != line)
                    {
                        line = Links[i].Line;
                        count++;
                    }
                }
                return count;
            }
        }

        #endregion

        #region 方法区域

        /// <summary>
        /// 判断是否包含指定的站点。
        /// </summary>
        /// <exception cref="ArgumentNullException">如果node为空引用，则跑出该异常。</exception>
        public bool ContainsNode(MetroNode node)
        {
            if (node == null) throw new ArgumentNullException("node");

            return Links.FirstOrDefault(c => c.From == node || c.To == node) != null;
        }

        /// <summary>
        /// 最佳一条新的Link，并返回一条新的路线。
        /// </summary>
        /// <exception cref="ArgumentNullException">如果link为空引用，则跑出该异常。</exception>
        public MetroPath Append(MetroLink link)
        {
            if (link == null) throw new ArgumentNullException("link");

            MetroPath newPath = new MetroPath();
            newPath.Links.AddRange(this.Links);
            newPath.Links.Add(link);
            return newPath;
        }

        /// <summary>
        /// 合并路线。
        /// </summary>
        /// <exception cref="ArgumentNullException">如果path为空引用，则跑出该异常。</exception>
        public MetroPath Merge(MetroPath path)
        {
            if (path == null) throw new ArgumentNullException("path");

            MetroPath newPath = new MetroPath();
            newPath.Links.AddRange(this.Links);
            newPath.Links.AddRange(path.Links);
            return newPath;
        }

        #endregion
    }
}
