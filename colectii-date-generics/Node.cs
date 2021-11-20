using System;
using System.Collections.Generic;
using System.Text;

namespace colectii_date_generics
{
    public class Node
    {
        private Masina data;
        private Node next;

        public Masina Data
        {
            get => this.data;
            set => this.data = value;
        }
        public Node Next
        {
            get => this.next;
            set => this.next = value;
        }
    }
}
