﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZH
{
    public class Field
    {
        private String _text;
        private String _color;
        private int _number;

        public int Type
        {
            get;
            set;
        }
        public String Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }
        public String Text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                }
            }
        }

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
            }
        }
        public Int32 X { get; set; }
        public Int32 Y { get; set; }

    }
}
