using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;

namespace DemoWebService
{
    /// <summary>
    /// Demo 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class Demo : System.Web.Services.WebService
    {

        [WebMethod(Description = "带参数的")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(Description = "传对象参数,返回对象参数")]
        [return: XmlElement(ElementName = "output")]
        public ResultDTO ParaMethod([XmlElement(ElementName = "input")]ParaDTO paraDTO)
        {
            ResultDTO resultDTO = new ResultDTO { msg = 0 };
            resultDTO.list = paraDTO;
            return resultDTO;
        }
    }

    /// <summary>
    /// 传过来的参数
    /// </summary>
    public class ParaDTO
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string NAME { set; get; }

        /// <summary>
        /// 性别
        /// </summary>
        public string SEX { set; get; }
    }

    /// <summary>
    /// 返回对象参数
    /// </summary>
    public class ResultDTO
    {
        /// <summary>
        /// 返回表示 0 请求失败 1 请求正常
        /// </summary>
        public int msg { set; get; }
        /// <summary>
        /// 返回结果列表
        /// </summary>
        public object list { set; get; }
    }
}
