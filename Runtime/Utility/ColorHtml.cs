using UnityEngine;

namespace Utility
{
    public readonly struct ColorHtml
    {
        private readonly Color _color;

        public ColorHtml(string code)
        {
            if (!code.StartsWith("#")) code = "#" + code;
            ColorUtility.TryParseHtmlString(code, out _color);
        }

        public ColorHtml(string code, int alpha32 = 255) : this(code)
        {
            _color.a = (float) alpha32 / byte.MaxValue;
        }

        public ColorHtml(string code, float alpha = 1f) : this(code)
        {
            _color.a = alpha;
        }

        public static implicit operator Color(ColorHtml colorHtml)
        {
            return colorHtml._color;
        }
    }
}
