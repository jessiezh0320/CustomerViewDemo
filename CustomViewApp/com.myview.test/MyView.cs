using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace com.myview.test
{
    class MyView : View
    {
        Context mContext;
        public MyView(Context context) :
        base(context)
        {
            init(context);
        }
        public MyView(Context context, IAttributeSet attrs) :
        base(context, attrs)
        {
            init(context);
        }

        public MyView(Context context, IAttributeSet attrs, int defStyle) :
        base(context, attrs, defStyle)
        {
            init(context);
        }

        private void init(Context ctx)
        {
            mContext = ctx;
        }


        protected override void OnDraw(Canvas canvas)
        {
            drawSmallCircles(canvas);
            
        }

        const int NUM_BUBBLES = 5;
        int radius = 60;
        private void drawSmallCircles(Canvas canvas)
        {

            int spacing = Width / NUM_BUBBLES;
            int shift = spacing / 2;
            int bottomMargin = 10;

            var paintCircle = new Paint() { Color = Color.Green };
            for (int i = 0; i < NUM_BUBBLES; i++)
            {
                int x = i * spacing + shift;
                int y = Height - radius * 2 - bottomMargin;
                canvas.DrawCircle(x, y, radius, paintCircle);
            }

        }
    }
}
