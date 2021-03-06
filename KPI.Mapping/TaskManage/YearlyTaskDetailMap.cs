﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPI.Domain.Entity;
using KPI.Domain.Entity.TaskManage;

namespace KPI.Mapping.TaskManage
{
    public class YearlyTaskDetailMap : EntityTypeConfiguration<YearlyTaskDetailEntity>
    {
        public YearlyTaskDetailMap()
        {
            this.ToTable("t_kpi_yearly_task_detail");
            this.HasKey(t => t.id);
        }
    }
}
