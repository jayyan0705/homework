using System;
using System.Linq;
using System.Collections.Generic;
	
namespace WebApplication1.Models
{   
	public  class vw客戶關聯資料表Repository : EFRepository<vw客戶關聯資料表>, Ivw客戶關聯資料表Repository
	{

	}

	public  interface Ivw客戶關聯資料表Repository : IRepository<vw客戶關聯資料表>
	{

	}
}