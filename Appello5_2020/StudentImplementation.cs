using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Appello5_2020_09_10 {
    namespace StudentCode {
        public static class Line {
            /// <summary>
            /// Given two sequences of double numbers, the function yields a sequence of functions on double numbers.
            /// The i-th function in the sequence represents the line having as slope and intercept the i-th elements
            /// of its parameters, respectively. In other words, a representation of the function y = ai * x + bi,
            /// where ai is the slope and bi the intercept.
            /// If <paramref name="yIntercepts"/> has length strictly smaller than <paramref name="slopes"/>,
            /// the missing intercepts will be set to 0.0
            /// </summary>
            /// <param name="slopes">the sequence of the slopes of the lines to be built</param>
            /// <param name="yIntercepts">the sequence of the intercepts of the lines to be built</param>
            /// <returns>
            /// the function sequence; the i-th function in it represents the line having the i-th
            /// element of <paramref name="slopes"/> as slope and the i-th element of <paramref name="yIntercepts"/>
            /// as intercept 
            /// </returns>
            /// <exception cref="ArgumentNullException">
            ///     if <paramref name="slopes"/> o <paramref name="yIntercepts"/> are null
            /// </exception> 
            /// <exception cref="ArgumentException">
            ///     if <paramref name="slopes"/> length is (strictly) smaller than <paramref name="yIntercepts"/> length
            /// </exception>
            /// <summary>
            /// Date due sequenze di double produce una sequenza di funzioni sui reali, l’i-esima delle quali
            /// rappresenta la retta avente come pendenza e termine noto l’i-esimo elemento rispettivamente
            /// dei due parametri, ovvero una rappresentazione della funzione y = ai  x + bi, dove ai è la
            /// pendenza e bi è il termine noto.
            /// In caso <paramref name="yIntercepts"/> abbia un numero di elementi strettamente minore di
            /// <paramref name="slopes"/>, i termini noti mancanti verranno sostituiti con 0.0
            /// </summary>
            /// <param name="slopes">la sequenza delle pendenze delle rette da costruire</param>
            /// <param name="yIntercepts">la sequenza dei termini noti delle rette da costruire</param>
            /// <returns>
            /// la sequenza di funzioni, l’i-esima delle quali rappresenta la retta avente come pendenza
            /// e termine noto l’i-esimo elemento rispettivamente di <paramref name="slopes"/> e
            /// di <paramref name="yIntercepts"/>
            /// </returns>
            /// <exception cref="ArgumentNullException">
            ///     se <paramref name="slopes"/> o <paramref name="yIntercepts"/> sono nulli
            /// </exception> 
            /// <exception cref="ArgumentException">
            ///     se <paramref name="slopes"/> ha un numero di elementi strettamente minore di <paramref name="yIntercepts"/>
            /// </exception>
            public static IEnumerable<Func<double, double>> LineProvider(this IEnumerable<double> slopes,
                IEnumerable<double> yIntercepts) {
                throw new NotImplementedException();
            }
        }

        namespace StudentTests {
            using StudentCode;

            [TestFixture]
            public class LineTest {
                /// <summary>
                /// Verifica che su una sequenza di pendenze lunga 5 e una sequenza di termni noti lunga 3
                /// il metodo sollevi l'eccezione ArgumentException.
                /// Verifies that on a slope sequence of length 5 and an intercept sequence of length 3
                /// the method throws ArgumentException.
                /// </summary>
                [Test]
                public void InsufficientInputThrows() {
                    throw new NotImplementedException();
                }

                /// <summary>
                /// Verifies that the first function returned by the method call on the slope sequence
                /// { 3.5, -4.76,3.22 } and the intercept sequence { -8.76, -42, -8.876 } is correct on
                /// all points from <paramref name="start"/> to <paramref name="stop"/> sampled by
                /// <paramref name="step"/>.
                /// For instance if <paramref name="start"/>==0, <paramref name="stop"/>==10, and
                /// <paramref name="step"/>==1, the points are {0, 1, 2,...,10} and if <paramref name="step"/>==3,
                /// the points are {0, 3, 6, 9} 
                /// </summary>
                /// <param name="approx">approximation used to compare double values</param>
                /// <param name="start">Starting point of the interval</param>
                /// <param name="stop">Ending point of the interval</param>
                /// <param name="step">Step between two considered point in the interval <paramref name="start"/> to
                /// <paramref name="stop"/></param>
                /// <summary>
                /// Verifica che la prima funzione restituita dal metodo sulla sequenza di inclinazioni
                /// { 3.5, -4.76,3.22 } e la sequenza di termini noti { -8.76, -42, -8.876 } sia corretta
                /// sull'insieme di punti compresi fra <paramref name="start"/> e <paramref name="stop"/>
                /// e distanti <paramref name="step"/> uno dall'altro.
                /// Ad esempio se <paramref name="start"/>==0 e <paramref name="stop"/>==10
                /// e <paramref name="step"/>==1, bisogna verificare sui punti {0, 1, 2,...,10} e se
                /// <paramref name="step"/>==3, i sui punti {0, 3, 6, 9}.
                /// </summary>
                /// <param name="approx">Approssimazione da usare nel confrontare valori double</param>
                /// <param name="start">Primo punto da controllare</param>
                /// <param name="stop">Limite oltre il quale non controllare</param>
                /// <param name="step">Dimensione del campionamento dei punti fra <paramref name="start"/>
                /// e <paramref name="stop"/> su cui controllare il risultato</param>
                [TestCase(0.0001, -200, 200, 2.5)]
                public void VerifyFirstLine(double approx, double start, double stop, double step) {
                    throw new NotImplementedException();
                }

                /// <summary>
                /// Verifica che il <paramref name="functionIndex"/>-esimo elemento (contando da 0) del risultato
                /// del metodo sulla sequenza INFINITA dei multipli di <paramref name="seed"/> a partire da
                /// <paramref name="seed"/> stesso (seed, 2 seed, 3 seed...) usata sia come pendenze che
                /// come termini noti restituisca sui punti {-100, -10, -1, 0, 1, 10, 100} i valori in
                /// <paramref name="expectedValues"/>.
                /// </summary>
                /// <param name="seed">
                /// Valore iniziale e incremento per entrambe le sequenze input del metodo (pendenze e termini noti)
                /// </param>
                /// <param name="functionIndex">L'indice della funzione da verificare (partendo da 0)</param>
                /// <param name="expectedValues">
                /// I valori attesi dalla funzione da verificare sulle ascisse -100, -10, -1, 0, 1, 10, 100
                /// </param>
                /// <summary>
                /// Verifies that the (zero-based) <paramref name="functionIndex"/>-th element of the result
                /// of the method call on the INFINITE sequence of <paramref name="seed"/> multiples
                /// starting from <paramref name="seed"/> (seed, 2 seed, 3 seed...) used both as slopes and intercepts
                /// on the input points {-100, -10, -1, 0, 1, 10, 100} yields the values in
                /// <paramref name="expectedValues"/>.
                /// </summary>
                /// <param name="seed">The initial value and step for both slopes and intersects</param>
                /// <param name="functionIndex">The zero-based index of the function to be checked</param>
                /// <param name="expectedValues">The values expected on input -100, -10, -1, 0, 1, 10, 100</param>
                [TestCase(2.5, 9, -2475, -225, 0, 25, 50, 275, 2525)]
                [TestCase(2.5, 2, -742.5, -67.5, 0, 7.5, 15, 82.5, 757.5)]
                public void OnInfiniteOk(double seed, int functionIndex, params double[] expectedValues) {
                    throw new NotImplementedException();
                }
            }
        }
    }
}