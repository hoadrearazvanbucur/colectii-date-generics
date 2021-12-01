using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_date_generics
{
    public class NodeTema
    {
        private int data;
        private NodeTema next;

        public int Data
        {
            get => this.data;
            set => this.data = value;
        }
        public NodeTema Next
        {
            get => this.next;
            set => this.next = value;
        }
    }
}
