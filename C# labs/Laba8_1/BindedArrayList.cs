using System.Collections;

namespace Laba8_1
{
    class BindedArrayList : ArrayList
    {
        private ListBox _control;
        private int _count;
        public BindedArrayList(int capacity, ListBox lstbox) : base(capacity)
        {
            _control = lstbox;
            _count = capacity;
        }
        public BindedArrayList() : base()
        {
            _count = 1;
        }
        public void Bind(ListBox control)
        {
            _control = control;
        }
        public void Update()
        {
            _control.Items.Clear();
            for (int i = 0; i < _count; i++) _control.Items.Add(this[i]);
        }

        public void SetCapacity(int capacity)
        {
            _count = Math.Min(capacity, Count);
            Update();
        }
        public override void Insert(int index, object? value)
        {
            _control.Items.Insert(index, value);
            base.Insert(index, value);
        }
        public override int Add(object? value)
        {
            _control.Items.Add(value);
            return base.Add(value);
        }

        public override void Clear()
        {
            _control.Items.Clear();
            base.Clear();
        }
    }
}
