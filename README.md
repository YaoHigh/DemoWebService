# DemoWebService
c#、.net 新建 webservice小Demo
步骤：


1、创建一个空的Web应用程序 DemoWebService



2、右键点击项目，选择 添加>新建项>Demo.asmx



3、在Demo.asmx.cs中已经有HelloWorld 方法


   同时为了可以参数传入已经对象返回，我添加了ParaMethod 参数为paraDTO，返回为ResultDTO


注意：如果方法需要通过webservice的地址进行调用，
      那就必须在方法上面打上 [WebMethod] 的特性标签，否则是无法通过webservice访问到的。Description 是方法的描述。

项目中的test.html是用ajax方式对WebService方法进行验证，注意


    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]

