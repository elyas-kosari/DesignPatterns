using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.Memento
{
    public class History
    {
        private readonly List<EditorState> _states = new List<EditorState>();
        private int _top = -1;

        public void Push(EditorState state)
        {
            _top++;
            _states.Add(state);
        }

        public EditorState Pop()
        {
            var state = _states[_top];
            _states.Remove(state);
            _top--;

            return state;
        }
    }
}
