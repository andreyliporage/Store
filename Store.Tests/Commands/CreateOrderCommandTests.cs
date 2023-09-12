using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Commands;
using System;
using System.Collections.Generic;

namespace Store.Tests.Commands
{
    [TestClass]
    public class CreateOrderCommandTests
    {
        [TestMethod]
        [TestCategory("Commands")]
        public void Dado_um_comando_invalido_o_pedido_nao_deve_ser_gerado()
        {
            var command = new CreateOrderCommand("", "13411080", "12345678", new List<CreateOrderItemCommand> { new CreateOrderItemCommand(Guid.NewGuid(), 1), new CreateOrderItemCommand(Guid.NewGuid(), 1) });
            command.Validate();

            Assert.IsTrue(command.Invalid);
        }
    }
}
