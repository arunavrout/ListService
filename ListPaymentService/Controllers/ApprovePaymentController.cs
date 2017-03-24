using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using ListPaymentService.Models;
using ListPaymentService.Providers;
using System.Threading.Tasks;
using System.Net;

namespace ListPaymentService.Controllers
{
    public class ApprovePaymentController : Controller
    {
        // GET: ApprovePayment

        public class ApproveController : ApiController
        {
            ApproveResponse res = null;
            [System.Web.Http.HttpPost]
            public async Task<IHttpActionResult> MakePayment([FromBody] ApproveRequesst payment)
            {
                try
                {
                    ApprovePayment client = new ApprovePayment();
                    res = await client.ApprovePayments(payment);
                }
                catch (Exception)
                {
                    return StatusCode(HttpStatusCode.BadRequest);
                }
                return Ok(res);
            }
        }

    }
}