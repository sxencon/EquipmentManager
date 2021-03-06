﻿using System;

namespace EquipmentManager.Controllers.Models
{
    //文件
    public class File
    {
        /// <summary>
        /// 组件Id
        /// </summary>
        public Guid ComponentId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public Guid CreateBy { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 设备Id
        /// </summary>
        public Guid EquipmentId { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 链接
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public Guid ModifyBy { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 大小（kb）
        /// </summary>
        public decimal Size { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        public Guid TenantId { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string Type { get; set; }
    }
}