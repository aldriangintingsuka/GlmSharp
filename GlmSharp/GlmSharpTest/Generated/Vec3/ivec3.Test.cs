using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Vec3
{
    [TestFixture]
    public class IntVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec3(-6);
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var v = new ivec3(8, -1, 1);
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var v = new ivec3(new ivec2(-9, 9));
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new ivec3(new ivec3(9, -6, -8));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new ivec3(new ivec4(7, -2, -1, 6));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-1, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec3(-6, -7, 2);
            Assert.AreEqual(-6, v[0]);
            Assert.AreEqual(-7, v[1]);
            Assert.AreEqual(2, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[2] = -6;
            Assert.AreEqual(-6, v[2]);
            v[2] = -7;
            Assert.AreEqual(-7, v[2]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[0] = -9;
            Assert.AreEqual(-9, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new ivec3(8, -9, -8);
            var vals = v.Values;
            Assert.AreEqual(8, vals[0]);
            Assert.AreEqual(-9, vals[1]);
            Assert.AreEqual(-8, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, ivec3.Zero.x);
            Assert.AreEqual(0, ivec3.Zero.y);
            Assert.AreEqual(0, ivec3.Zero.z);
            
            Assert.AreEqual(1, ivec3.Ones.x);
            Assert.AreEqual(1, ivec3.Ones.y);
            Assert.AreEqual(1, ivec3.Ones.z);
            
            Assert.AreEqual(1, ivec3.UnitX.x);
            Assert.AreEqual(0, ivec3.UnitX.y);
            Assert.AreEqual(0, ivec3.UnitX.z);
            
            Assert.AreEqual(0, ivec3.UnitY.x);
            Assert.AreEqual(1, ivec3.UnitY.y);
            Assert.AreEqual(0, ivec3.UnitY.z);
            
            Assert.AreEqual(0, ivec3.UnitZ.x);
            Assert.AreEqual(0, ivec3.UnitZ.y);
            Assert.AreEqual(1, ivec3.UnitZ.z);
            
            Assert.AreEqual(int.MaxValue, ivec3.MaxValue.x);
            Assert.AreEqual(int.MaxValue, ivec3.MaxValue.y);
            Assert.AreEqual(int.MaxValue, ivec3.MaxValue.z);
            
            Assert.AreEqual(int.MinValue, ivec3.MinValue.x);
            Assert.AreEqual(int.MinValue, ivec3.MinValue.y);
            Assert.AreEqual(int.MinValue, ivec3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new ivec3(8, -6, -2);
            var v2 = new ivec3(8, -6, -2);
            var v3 = new ivec3(-2, -6, 8);
            Assert.That(v1 == new ivec3(v1));
            Assert.That(v2 == new ivec3(v2));
            Assert.That(v3 == new ivec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new ivec3(2, 1, 9);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = ivec3.Parse(s0);
            var v1 = ivec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = ivec3.TryParse(s0, out v0);
            var b1 = ivec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = ivec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = ivec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = ivec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { ivec3.Parse(null); });
            Assert.Throws<FormatException>(() => { ivec3.Parse(""); });
            Assert.Throws<FormatException>(() => { ivec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = ivec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = ivec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = ivec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new ivec3(8, 2, 7);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<ivec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new ivec3(1, 7, -4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(-6, -7, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(6, -9, -8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(9, -5, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(-7, -3, 8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(9, 3, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(1, 8, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(2, -5, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(-5, 5, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec3(1, -6, 8);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new ivec3(-5, 5, 5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(-4, -4, 7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(-7, 1, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(9, 1, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(-7, -2, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(5, 9, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(6, -1, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(-2, -2, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(-9, -1, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec3(-6, -7, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new ivec3(3, 6, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(4, 6, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(2, -2, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(-9, 0, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(1, -9, 0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(7, -1, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(7, 3, -3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(1, -4, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(0, 9, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec3(4, -9, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new ivec3(-8, 5, 3);
                var v1 = new ivec3(5, 7, 4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(6, 6, 7);
                var v1 = new ivec3(-5, 4, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(1, -5, -8);
                var v1 = new ivec3(-1, 8, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(-3, 1, 9);
                var v1 = new ivec3(-8, -6, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(-1, 0, 6);
                var v1 = new ivec3(7, -6, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(7, 9, 5);
                var v1 = new ivec3(5, -1, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(2, -7, 7);
                var v1 = new ivec3(-2, -7, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(-5, 8, 4);
                var v1 = new ivec3(-9, 1, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(3, -6, -2);
                var v1 = new ivec3(8, -5, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec3(6, -9, 9);
                var v1 = new ivec3(-5, -5, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new ivec3(-9, -2, 3);
                var v1 = new ivec3(-8, 0, -6);
                var v2 = new ivec3(6, 6, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(0, 9, 5);
                var v1 = new ivec3(-8, -3, 5);
                var v2 = new ivec3(-4, -4, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(5, 2, 3);
                var v1 = new ivec3(5, -7, 4);
                var v2 = new ivec3(5, 5, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(9, -2, 2);
                var v1 = new ivec3(-9, 4, -7);
                var v2 = new ivec3(4, -4, 7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(3, -3, -7);
                var v1 = new ivec3(-6, -4, 4);
                var v2 = new ivec3(4, 3, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(-7, -1, 3);
                var v1 = new ivec3(5, -5, 6);
                var v2 = new ivec3(-7, -1, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(1, -4, -5);
                var v1 = new ivec3(-9, -3, -5);
                var v2 = new ivec3(-3, -6, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(-3, 1, 4);
                var v1 = new ivec3(8, -3, -9);
                var v2 = new ivec3(-7, -1, 1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(-8, 8, 8);
                var v1 = new ivec3(-8, 1, -3);
                var v2 = new ivec3(-9, 7, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec3(-9, 4, -6);
                var v1 = new ivec3(-6, 2, -3);
                var v2 = new ivec3(-3, 3, 0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new ivec3(0, 5, 1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-7, 6, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-4, 1, -9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-5, 6, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-3, 6, -3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(9, -2, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-8, -3, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-2, 1, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-9, 5, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec3(-6, -9, -5);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new ivec3(2, -8, 8);
                var v1 = new ivec3(-9, -5, -2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(-2, 6, -4);
                var v1 = new ivec3(7, 0, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(1, 8, 2);
                var v1 = new ivec3(-8, -6, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(6, -7, 8);
                var v1 = new ivec3(1, -8, -7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(8, 8, 6);
                var v1 = new ivec3(-6, -1, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(-5, -5, -9);
                var v1 = new ivec3(4, -2, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(1, 0, -9);
                var v1 = new ivec3(-2, 7, 3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(9, 1, -6);
                var v1 = new ivec3(3, -2, -2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(-4, -6, 4);
                var v1 = new ivec3(2, -7, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec3(-4, 1, -9);
                var v1 = new ivec3(-2, -1, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new ivec3(-9, 1, 2);
                var v1 = new ivec3(9, -9, 8);
                var v2 = new ivec3(5, 2, -5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(7, 8, -2);
                var v1 = new ivec3(-8, -7, 9);
                var v2 = new ivec3(8, -4, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(9, 6, 1);
                var v1 = new ivec3(1, 0, -9);
                var v2 = new ivec3(-6, 8, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(-5, -4, -2);
                var v1 = new ivec3(7, 8, 1);
                var v2 = new ivec3(-6, -4, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(-6, 2, -3);
                var v1 = new ivec3(6, 0, -4);
                var v2 = new ivec3(0, 1, -8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(1, 9, 7);
                var v1 = new ivec3(9, -6, 8);
                var v2 = new ivec3(-1, -7, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(-6, -7, 1);
                var v1 = new ivec3(3, -4, 9);
                var v2 = new ivec3(-5, -1, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(3, -9, -9);
                var v1 = new ivec3(9, 2, 3);
                var v2 = new ivec3(-6, -2, -2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(-2, 2, 6);
                var v1 = new ivec3(6, 1, -8);
                var v2 = new ivec3(1, -4, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec3(4, 4, -7);
                var v1 = new ivec3(3, -7, -2);
                var v2 = new ivec3(7, 0, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

    }
}
