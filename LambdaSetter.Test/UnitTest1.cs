using System;
using Xunit;

namespace LambdaSetter.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var data = new Data { Entrada = "entrada", Value = 2 };
            Setter.GetSetter<Data, string>(d => d.Entrada)(data, "Saida");
            Setter.GetSetter<Data, int>(d => d.Value)(data, 5);
            Assert.True(data.Entrada == "Saida");
            Assert.True(data.Value == 5);

        }

        private class Data
        {
            public string Entrada { get; set; }
            public int Value { get; set; }
        }
    }

}
