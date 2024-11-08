﻿using BaiTap4.Models;
using BaiTap4.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap4.ViewComponents
{
	public class LoaiSpMenuViewComponent : ViewComponent
	{
		private readonly ILoaiSpRepository _loaiSp;
		public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
		{
			_loaiSp = loaiSpRepository;
		}
		public IViewComponentResult Invoke()
		{
			var loaiSp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Loai);
			return View(loaiSp);
		}
	}
}
