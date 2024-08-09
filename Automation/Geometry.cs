//By AlSch092 @ Github
﻿using Mir4ClientEmulator.Network.Packets.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mir4.Scripter
{
    public class Geometry
    {
        static public float GetDistance(_vector3 v, _vector3 t)
        {
            float deltaX = t.x - v.x; float deltaY = t.y - v.y; float deltaZ = t.z - v.z; //subtract point 2 from point 1 then take squart root of x^2 + y^2 + z^2
            return (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }

        public static float Distance(_vector3 value1, _vector3 value2)
        {
            float num2 = value1.x - value2.x;
            float num3 = value1.y - value2.y;
            float num4 = value1.z - value2.z;
            float num5 = num2 * num2 + num3 * num3 + num4 * num4;
            return (float)Math.Sqrt(num5);
        }

        public static List<_vector3> GetClosebyVectors(_vector3 referenceVector, List<_vector3> vectorList, float distanceThreshold)
        {
            List<_vector3> closebyVectors = new List<_vector3>();

            foreach (_vector3 vector in vectorList)
            {
                if (Geometry.Distance(referenceVector, vector) <= distanceThreshold)
                {
                    closebyVectors.Add(vector);
                }
            }

            return closebyVectors;
        }

        public static _vector3[] SplitVector(_vector3 _start, _vector3 end, int segments)
        {
            if (segments < 2)
            {
                throw new ArgumentException("Number of segments must be at least 2");
            }

            _vector3[] result = new _vector3[segments];
            float step = 1f / (segments - 1);

            for (int i = 0; i < segments; i++)
            {
                float t = i * step;
                _vector3 _result = new _vector3();
                _result.x = _start.x + (end.x - _start.x) * t;
                _result.y = _start.y + (end.y - _start.y) * t;
                _result.z = _start.z + (end.z - _start.z) * t;
                result[i] = _result;
            }

            return result;
        }
    }
}
