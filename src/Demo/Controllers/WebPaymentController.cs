﻿using ICanPay;
using System;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class WebPaymentController : Controller
    {
        public void CreateAlipayOrder()
        {
            PaymentSetting paymentSetting = new PaymentSetting(GatewayType.Alipay);
            paymentSetting.Merchant.Email= "yourname@address.com";
            paymentSetting.Merchant.Partner = "000000000000000";
            paymentSetting.Merchant.Key = "000000000000000000000000000000000000000000";
            paymentSetting.Merchant.NotifyUrl = new Uri("http://yourwebsite.com/Notify.aspx");

            paymentSetting.Order.OrderAmount = 0.01;
            paymentSetting.Order.OrderNo = "35";
            paymentSetting.Order.Subject = "测测看支付宝";
            paymentSetting.Payment();
        }

        /// <summary>
        /// 创建微信的支付订单
        /// </summary>
        private void CreateWeChatPayOrder()
        {
            PaymentSetting paymentSetting = new PaymentSetting(GatewayType.WeChatPayment);
            paymentSetting.Merchant.AppId = "wx000000000000000";
            paymentSetting.Merchant.Partner = "000000000000000";
            paymentSetting.Merchant.Key = "000000000000000000000000000000000000000000";
            paymentSetting.Merchant.NotifyUrl = new Uri("http://yourwebsite.com/Notify.aspx");

            paymentSetting.Order.OrderAmount = 0.01;
            paymentSetting.Order.OrderNo = "35";
            paymentSetting.Order.Subject = "测测看微信";
            paymentSetting.Payment();
        }
    }
}