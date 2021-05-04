﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitatManagement.BusinessEntities
{
    public class PermitFormScreenDesignTemplateDetailBE : BusinessEntity
    {
        public int FormID { get; set; }

        public int Field { get; set; }

        public string FieldName { get; set; }

        public FormFieldType FieldType { get; set; }

        [MaxFieldLength(20)]
        public string Section { get; set; }

        public int Sequence { get; set; }


        public string FieldTypeValue { get; set; }

        public string SectionDescription { get; set; }

        public int SectionSequence { get; set; }
    }
}