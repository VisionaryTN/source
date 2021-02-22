using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		[Route("/clayweb")]
		public string GetHtml(int i)
		{
		
			//让单元测试的覆盖度95% 
			// 一个接口本100代码 10
			//一个接口的单元测试,可能需要500行 //一个小时
			return "美滋滋+美滋滋+美滋滋";
		}

	}
}
