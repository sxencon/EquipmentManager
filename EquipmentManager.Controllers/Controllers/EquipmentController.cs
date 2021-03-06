﻿using System;
using System.Web.Mvc;
using JingBaiHui.Common.Models;
using EquipmentManager.Controllers.Models;
using EquipmentManager.Controllers.Provider;
using System.Web;

namespace EquipmentManager.Controllers.Controllers
{
    public class EquipmentController : BaseController
    {
        [HttpPost]
        public JsonResult Delete(Guid Id)
        {
            EquipmentProvider.Instance.Delete(Id);
            return Json(new ResponseModel() { Status = true });
        }

        public ViewResult Detail()
        {
            return View();
        }

        public JsonResult Get(Guid Id)
        {
            var model = EquipmentProvider.Instance.Get(Id);
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetList(Equipment entity)
        {
            entity.TenantId = this.TenantId;
            var list = EquipmentProvider.Instance.GetEasyUiDataList(entity, this.PageIndex, this.PageSize, this.OrderBy);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Save(Equipment entity)
        {
            entity.TenantId = this.TenantId;
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
                entity.CreateBy = this.UserId;
                entity.CreateTime = DateTime.Now;
                entity.ModifyBy = this.UserId;
                entity.ModifyTime = DateTime.Now;
                entity.ImageLink = UploadImg("EquipmentImageLink");
                EquipmentProvider.Instance.Create(entity);
            }
            else
            {
                var newImg = UploadImg("EquipmentImageLink");
                if (!string.IsNullOrWhiteSpace(newImg))
                {
                    entity.ImageLink = newImg;
                }
                entity.ModifyBy = this.UserId;
                entity.ModifyTime = DateTime.Now;
                EquipmentProvider.Instance.Update(entity);
            }
            return Json(new ResponseModel() { Status = true });
        }
    }
}