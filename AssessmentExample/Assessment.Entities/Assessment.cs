﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Entities
{
    public class Assessment
    {
        public int AssessmentID { get; set; }
        public int LevelNumber { get; set; }
        public int SubjectID { get; set; }
        public string Name { get; set; }
    }
}
