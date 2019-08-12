using System;
using System.Collections.Generic;
using System.Text;

namespace A01.xception
{
    class [Serializable]
public class SaldoInvalido: Exception
{
    public SaldoInvalido() { }
    public SaldoInvalido(string message) : base(message) { }
    public SaldoInvalido(string message, Exception inner) : base(message, inner) { }
    protected SaldoInvalido(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
{
}
}
