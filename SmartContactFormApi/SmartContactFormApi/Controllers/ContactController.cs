using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SmartContactFormApi.Models;

namespace SmartContactFormApi.Controllers
{
    public class ContactController : ApiController
    {

        public ContactUsEmailResponse Post(ContactUsEmailRequest emailRequest)
        {
            if (emailRequest == null)
            {
                HttpResponseMessage errorResponse = Request.CreateErrorResponse(HttpStatusCode.BadRequest, new HttpError("Invalid Request"));
                throw new HttpResponseException(errorResponse);
            }


            if (emailRequest.SubjectType.IsCancelRequest())
            {

            }




            return new ContactUsEmailResponse();
        }


        public ContactUsEmailSubjects GetSubjects()
        {
            return new ContactUsEmailSubjects();
        }

    }
}
