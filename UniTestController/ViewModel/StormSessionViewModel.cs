﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniTestController.ViewModel
{
    public class StormSessionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public int IdeaCount { get; set; }
    }
}
