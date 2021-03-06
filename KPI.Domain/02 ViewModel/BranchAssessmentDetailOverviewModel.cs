﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPI.Domain.ViewModel
{
    public class BranchAssessmentDetailOverviewModel
    {
        public string assessment_id { get; set; }
        /// <summary>
        /// 考核名称
        /// </summary>
        public string assessment_name { get; set; }
        /// <summary>
        /// 考核对象
        /// </summary>
        public string check_object { get; set; }
        /// <summary>
        /// 考核模板名称
        /// </summary>
        public string templete_name { get; set; }
        /// <summary>
        /// 分公司id
        /// </summary>
        public string branch_id { get; set; }
        /// <summary>
        /// 分公司名称
        /// </summary>
        public string branch_name { get; set; }
        /// <summary>
        /// 考核开始时间
        /// </summary>
        public DateTime? start_time { get; set; }
        /// <summary>
        /// 考核结束时间
        /// </summary>
        public DateTime? end_time { get; set; }
        /// <summary>
        /// 考核进度
        /// </summary>
        public int? assessment_detail_statue { get; set; }
        /// <summary>
        /// 考核进度详细
        /// </summary>
        public string assessment_statue_detail { get; set; }
        /// <summary>
        /// 考评得分
        /// </summary>
        public double? score { get; set; }
        /// <summary>
        /// 是否可以点击考核
        /// </summary>
        public int? flag { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_time { get; set; }
    }
}
