using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehaviouralPatterns.Memento
{
    public class Editor
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content, FontName, FontSize);
        }

        public void RestoreContent(EditorState state)
        {
            Content = state.GetContent();
        }
        public void RestoreFontName(EditorState state)
        {
            FontName = state.GetFontName();
        }
        public void RestoreFontSize(EditorState state)
        {
            FontSize = state.GetFontSize();
        }

    }
}
