using System;

namespace GlmNet
{
    /// <summary>
    /// Represents a three dimensional vector.
    /// </summary>
    public struct vec3
    {
        public float x;
        public float y;
        public float z;

        public float this[int index]
        {
            get => index == 0 ? x : index == 1 ? y : index == 2 ? z : throw new Exception("Out of range.");
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
                else
                {
                    z = index == 2 ? value : throw new Exception("Out of range.");
                }
            }
        }

        public vec3(float s)
        {
            x = y = z = s;
        }

        public vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public vec3(vec3 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }

        public vec3(vec4 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }

        public vec3(vec2 xy, float z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        public static vec3 operator +(vec3 lhs, vec3 rhs)
        {
            return new vec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        public static vec3 operator +(vec3 lhs, float rhs)
        {
            return new vec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        }

        public static vec3 operator -(vec3 lhs, vec3 rhs)
        {
            return new vec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        public static vec3 operator -(vec3 lhs, float rhs)
        {
            return new vec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        }

        public static vec3 operator *(vec3 self, float s)
        {
            return new vec3(self.x * s, self.y * s, self.z * s);
        }
        public static vec3 operator *(float lhs, vec3 rhs)
        {
            return new vec3(rhs.x * lhs, rhs.y * lhs, rhs.z * lhs);
        }

        public static vec3 operator /(vec3 lhs, float rhs)
        {
            return new vec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        public static vec3 operator *(vec3 lhs, vec3 rhs)
        {
            return new vec3(rhs.x * lhs.x, rhs.y * lhs.y, rhs.z * lhs.z);
        }

        public float[] to_array() => new[] { x, y, z };

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
            if (obj.GetType() == typeof(vec3))
            {
                vec3 vec = (vec3)obj;
                if (x == vec.x && y == vec.y && z == vec.z)
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
        public static bool operator ==(vec3 v1, vec3 v2)
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
        public static bool operator !=(vec3 v1, vec3 v2)
        {
            return !v1.Equals(v2);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();

        #endregion

        #region ToString support

        public override string ToString() => string.Format("[{0}, {1}, {2}]", x, y, z);

        #endregion
    }
}
