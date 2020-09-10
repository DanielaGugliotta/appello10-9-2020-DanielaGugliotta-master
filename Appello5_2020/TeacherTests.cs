using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Appello5_2020_09_10 {
    namespace TeacherTests {
        using StudentCode;

        [TestFixture]
        public class LineProviderTest {
            const double Approx = 0.00000001;
            [Test]
            public void OnNullSlopesThrows() {
                Assert.That(() => Line.LineProvider(null, new double[] { 3.5, 2.78 }).GetEnumerator().MoveNext(),
                    Throws.InstanceOf<ArgumentNullException>());
            }
            [Test]
            public void CorrectlyCreates5() {
                var slopes = new[] { 1.0, 0.56, -7.5, .56, 0.0 };
                var yInters = new[] { 5.7, Math.PI };
                var res = slopes.LineProvider(yInters).ToArray();
                Assert.That(res, Has.Length.EqualTo(5));
            }
            [Test]
            public void CorrectFirstLine() {
                var slopes = new[] { 0.5, 0, -7 };
                var yInters = new[] { 5.87, 4, -6.8 };
                var res = slopes.LineProvider(yInters).First();
                var xValues = new[] { -1000, -.54, 0.0, 1, 100 };
                Assert.Multiple(() => {
                    foreach (var x in xValues) {
                        Assert.That(Math.Abs(res(x) - Compute(x)), Is.LessThan(Approx));
                    }
                });
                double Compute(double x) => x / 2 + 5.87;
            }
            [Test]
            public void CorrectLineDefaultIntercept() {
                var slopes = new[] { 2.5, 0, -7 };
                var yInters = new double[0];
                var res = slopes.LineProvider(yInters).First();
                var xValues = new[] { -1000, -.54, 0.0, 1, 100 };
                Assert.Multiple(() => {
                    foreach (var x in xValues) {
                        Assert.That(Math.Abs(res(x) - 2.5 * x), Is.LessThan(Approx));
                    }
                });
            }
        }
    }
}