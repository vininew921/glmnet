using System;

namespace GlmNet
{
    /// <summary>
    /// Represents a four dimensional vector.
    /// </summary>
    public struct vec4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public float this[int index]
        {
            get => index == 0 ? x : index == 1 ? y : index == 2 ? z : index == 3 ? w : throw new Exception("Out of range.");
            set
            {
                if (index == 0)
                {
                    x = value;
                }
                else if (index == 1)
                {
                    y = value;
                }
                else if (index == 2)
                {
                    z = value;
                }
                else
                {
                    w = index == 3 ? value : throw new Exception("Out of range.");
                }
            }
        }

        public vec4(float s)
        {
            x = y = z = w = s;
        }

        public vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public vec4(vec4 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }

        public vec4(vec3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        public static vec4 operator +(vec4 lhs, vec4 rhs)
        {
            return new vec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        public static vec4 operator +(vec4 lhs, float rhs)
        {
            return new vec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        }

        public static vec4 operator -(vec4 lhs, float rhs)
        {
            return new vec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        }

        public static vec4 operator -(vec4 lhs, vec4 rhs)
        {
            return new vec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        public static vec4 operator *(vec4 self, float s)
        {
            return new vec4(self.x * s, self.y * s, self.z * s, self.w * s);
        }

        public static vec4 operator *(float lhs, vec4 rhs)
        {
            return new vec4(rhs.x * lhs, rhs.y * lhs, rhs.z * lhs, rhs.w * lhs);
        }

        public static vec4 operator *(vec4 lhs, vec4 rhs)
        {
            return new vec4(rhs.x * lhs.x, rhs.y * lhs.y, rhs.z * lhs.z, rhs.w * lhs.w);
        }

        public static vec4 operator /(vec4 lhs, float rhs)
        {
            return new vec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        }

        public float[] to_array() => new[] { x, y, z, w };

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
            if (obj.GetType() == typeof(vec4))
            {
                vec4 vec = (vec4)obj;
                if (x == vec.x && y == vec.y && z == vec.z && w == vec.w)
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
        public static bool operator ==(vec4 v1, vec4 v2)
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
        public static bool operator !=(vec4 v1, vec4 v2)
        {
            return !v1.Equals(v2);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();

        #endregion

        #region ToString support

        public override string ToString() => string.Format("[{0}, {1}, {2}, {3}]", x, y, z, w);

        #endregion
    }
}
