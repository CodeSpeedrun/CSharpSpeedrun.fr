using System;
using System.Collections.Generic;

namespace CSharpSpeedrun {
    public class Program {
        static void Main() {
            IMarkingSystem ms = getMarkingSystem();
            Console.WriteLine(ms.calculatePassingMark());
        }

        public static IMarkingSystem getMarkingSystem() {
            return new MarkingSystem2019();
        }
    }

    public class MarkingSystem2022 : IMarkingSystem {
        public float calculatePassingMark() {
            return 40;
        }
    }
    public class MarkingSystem2019 : IMarkingSystem {
        public float calculatePassingMark() {
            return 35;
        }

        public float calculateGPA() {
            return 3;
        }
    }
    public interface IMarkingSystem {
        float calculatePassingMark();
    }
}
//35