﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
	public class VehiculosController : Controller
	{
		// GET: VehiculoController
		public ActionResult GetVehiculos()
		{
			return View();
		}

		// GET: VehiculoController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: VehiculoController/Create
		public ActionResult CreateVehiculo()
		{
			return View();
		}

		// POST: VehiculoController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: VehiculoController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: VehiculoController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: VehiculoController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: VehiculoController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
