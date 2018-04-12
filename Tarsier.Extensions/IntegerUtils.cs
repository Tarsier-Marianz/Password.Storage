using System;
namespace Tarsier.Extensions {
    public static class IntegerUtils {
        public static int ToSafeInteger(this object integerValue) {
            int outInt = 0;
            if(int.TryParse(integerValue.ToString(), out outInt)) {
                return outInt;
            }
            return outInt;
        }

        public static int ToSafeInteger(this string integerValue) {
            if(!String.IsNullOrWhiteSpace(integerValue)) {
                int outInt = 0;
                if(int.TryParse(integerValue.Trim(), out outInt)) {
                    return outInt;
                }
            }
            return 0;
        }
    }
}
