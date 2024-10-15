using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESERCIZIO_1_classi_astratte_e_interfacce
{
    public interface IDrawable
    {
        void setColor();
        void setPosition();
        void draw();
    }
    public interface IEquatable<T>
    {
        bool Equals(T other);
    }
    public class DrawableCircle : CCircle, IDrawable, IEquatable<DrawableCircle>
    {
        public bool Equals(DrawableCircle other)
        {
            return true;
        }
        public void setColor()
        {

        }
        public void setPosition()
        {

        }
        public void draw()
        {

        }
    }
    public class DrawableRectangle : CCircle, IDrawable,IEquatable<DrawableRectangle>
    {
        public bool Equals(DrawableRectangle other)
        {
            return true;
        }
        public void setColor()
        {

        }
        public void setPosition()
        {

        }
        public void draw()
        {

        }
    }
}