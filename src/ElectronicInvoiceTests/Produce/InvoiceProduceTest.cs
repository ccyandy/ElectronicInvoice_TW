﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ElectronicInvoice.Service.Base;
using Moq;
using ElectronicInvoice.Models;
using ElectronicInvoice.Core.Infrastructure.Factroy;

namespace ElectronicInvoiceTests.Produce
{
    [TestFixture]
    public class InvoiceProduceTest
    {
        [TestCase]
        public void Test()
        {
            QryWinningListModel model = new QryWinningListModel() { invTerm = "10406" };
            MoblieInvoiceApiFactroy factory = new MoblieInvoiceApiFactroy();
            var api = factory.GetProxyInstace(model);
            string result = api.ExcuteApi(model);
            string except = "{\"fifthPrizeAmt\":\"0001000\",\"firstPrizeAmt\":\"0200000\",\"firstPrizeNo1\":\"07836485\",\"firstPrizeNo10\":\"\",\"firstPrizeNo2\":\"13410946\",\"firstPrizeNo3\":\"96152286\",\"firstPrizeNo4\":\"\",\"firstPrizeNo5\":\"\",\"firstPrizeNo6\":\"\",\"firstPrizeNo7\":\"\",\"firstPrizeNo8\":\"\",\"firstPrizeNo9\":\"\",\"fourthPrizeAmt\":\"0004000\",\"invoYm\":\"10604\",\"secondPrizeAmt\":\"0040000\",\"sixthPrizeAmt\":\"0000200\",\"sixthPrizeNo1\":\"996\",\"sixthPrizeNo2\":\"\",\"sixthPrizeNo3\":\"\",\"sixthPrizeNo4\":\"\",\"sixthPrizeNo5\":\"\",\"sixthPrizeNo6\":\"\",\"spcPrizeAmt\":\"2000000\",\"spcPrizeNo\":\"82528918\",\"spcPrizeNo2\":\"\",\"spcPrizeNo3\":\"\",\"superPrizeAmt\":\"10000000\",\"superPrizeNo\":\"74748874\",\"thirdPrizeAmt\":\"0010000\",\"timeStamp\":{\"date\":25,\"day\":4,\"hours\":14,\"minutes\":20,\"month\":4,\"seconds\":3,\"time\":1495693203000,\"timezoneOffset\":-480,\"year\":117},\"updateDate\":\"1060525\",\"v\":\"0.2\",\"code\":\"200\",\"msg\":\"查詢成功\"}";

            Assert.AreEqual(result, except);
        }
    }
}