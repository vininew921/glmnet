using System;

namespace GlmNet
{
    /// <summary>
    /// Represents a two dimensional vector.
    /// </summary>
    public struct vec2
    {
        public float x;
        public float y;

        public float this[int index]
        {
            get => index == 0 ? x : index == 1 ? y : throw new Exception("Out of range.");
            set
            {
                if (index == 0)
                {
                    x = value;
                }
                else
                {
                    y = index == 1 ? value : throw new Exception("Out of range.");
                }
            }
        }

        public vec2(float s)
        {
            x = y = s;
        }

        public vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public vec2(vec2 v)
        {
            x = v.x;
            y = v.y;
        }

        public vec2(vec3 v)
        {
            x = v.x;
            y = v.y;
        }

        public static vec2 operator +(vec2 lhs, vec2 rhs)
        {
            return new vec2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static vec2 operator +(vec2 lhs, float rhs)
        {
            return new vec2(lhs.x + rhs, lhs.y + rhs);
        }

        public static vec2 operator -(vec2 lhs, vec2 rhs)
        {
            return new vec2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        public static vec2 operator -(vec2 lhs, float rhs)
        {
            return new vec2(lhs.x - rhs, lhs.y - rhs);
        }

        public static vec2 operator *(vec2 self, float s)
        {
            return new vec2(self.x * s, self.y * s);
        }

        public static vec2 operator *(float lhs, vec2 rhs)
        {
            return new vec2(rhs.x * lhs, rhs.y * lhs);
        }

        public static vec2 operator *(vec2 lhs, vec2 rhs)
        {
            return new vec2(rhs.x * lhs.x, rhs.y * lhs.y);
        }

        public static vec2 operator /(vec2 lhs, float rhs)
        {
            return new vec2(lhs.x / rhs, lhs.y / rhs);
        }

        public float[] to_array() => new[] { x, y };

        #region Comparision

        /// <summary>
        /// Determines whether the specified <see cref="object" />, is equal to this instance.
        /// The Difference is detected by the different values
        /// </summary>
        /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(vec2))
            {
                vec2 vec = (vec2)obj;
                if (x == vec.x && y == vec.y)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="v1">The first Vector.</param>
        /// <param name="v2">The second Vector.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(vec2 v1, vec2 v2)
        {
            return v1.Equals(v2);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="v1">The first Vector.</param>
        /// <param name="v2">The second Vector.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(vec2 v1, vec2 v2)
        {
            return !v1.Equals(v2);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();

        #endregion

        #region ToString support

        public override string ToString() => string.Format("[{0}, {1}]", x, y);

        #endregion
    }
}
