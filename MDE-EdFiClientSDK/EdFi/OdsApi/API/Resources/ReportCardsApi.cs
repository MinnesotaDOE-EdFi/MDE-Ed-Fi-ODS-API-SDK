using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.Resources;
using RestSharp;
  
namespace EdFi.OdsApi.Api.Resources 
{
    public class ReportCardsApi 
    {
        private readonly IRestClient client;

        public ReportCardsApi(IRestClient client)
        {
            this.client = client;
        }
      
        /// <summary>
        /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<ReportCard>> GetReportCardsAll(int? offset= null, int? limit= null) 
        {
            var request = new RestRequest("/reportCards", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<ReportCard>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves resources matching values of an example resource (using the &quot;Get By Example&quot; pattern). This GET operation provides access to resources using the &quot;Get by Example&quot; search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <param name="educationOrganizationId">EducationOrganization Identity Column</param>
        /// <param name="gradingPeriodDescriptor">The name of the grading period during the school year in which the grade is offered (e.g., 1st cycle, 1st semester)</param>
        /// <param name="schoolId">School Identity Column</param>
        /// <param name="gradingPeriodBeginDate">Month, day, and year of the first day of the grading period.</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        /// <param name="gpaGivenGradingPeriod">A measure of average performance in all courses taken by an individual for the current grading period.</param>
        /// <param name="gpaCumulative">A measure of cumulative average performance in all courses taken by an individual from the beginning of the school year through the current grading period.</param>
        /// <param name="numberOfDaysAbsent">The number of days an individual is absent when school is in session during a given reporting period.</param>
        /// <param name="numberOfDaysInAttendance">The number of days an individual is present when school is in session during a given reporting period.</param>
        /// <param name="numberOfDaysTardy">The number of days an individual is tardy during a given reporting period.</param>
        /// <param name="id"></param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<ReportCard>> GetReportCardsByExample(int? offset= null, int? limit= null, int? educationOrganizationId= null, string gradingPeriodDescriptor= null, int? schoolId= null, DateTime? gradingPeriodBeginDate= null, string studentUniqueId= null, double? gpaGivenGradingPeriod= null, double? gpaCumulative= null, double? numberOfDaysAbsent= null, double? numberOfDaysInAttendance= null, int? numberOfDaysTardy= null, string id= null) 
        {
            var request = new RestRequest("/reportCards", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            if (educationOrganizationId != null)
                request.AddParameter("educationOrganizationId", educationOrganizationId);
            if (gradingPeriodDescriptor != null)
                request.AddParameter("gradingPeriodDescriptor", gradingPeriodDescriptor);
            if (schoolId != null)
                request.AddParameter("schoolId", schoolId);
            if (gradingPeriodBeginDate != null)
                request.AddParameter("gradingPeriodBeginDate", gradingPeriodBeginDate);
            if (studentUniqueId != null)
                request.AddParameter("studentUniqueId", studentUniqueId);
            if (gpaGivenGradingPeriod != null)
                request.AddParameter("gpaGivenGradingPeriod", gpaGivenGradingPeriod);
            if (gpaCumulative != null)
                request.AddParameter("gpaCumulative", gpaCumulative);
            if (numberOfDaysAbsent != null)
                request.AddParameter("numberOfDaysAbsent", numberOfDaysAbsent);
            if (numberOfDaysInAttendance != null)
                request.AddParameter("numberOfDaysInAttendance", numberOfDaysInAttendance);
            if (numberOfDaysTardy != null)
                request.AddParameter("numberOfDaysTardy", numberOfDaysTardy);
            if (id != null)
                request.AddParameter("id", id);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<ReportCard>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
        /// </summary>
        /// <param name="educationOrganizationId">EducationOrganization Identity Column</param>
        /// <param name="gradingPeriodBeginDate">Month, day, and year of the first day of the grading period.</param>
        /// <param name="gradingPeriodDescriptor">The name of the grading period during the school year in which the grade is offered (e.g., 1st cycle, 1st semester)</param>
        /// <param name="schoolId">School Identity Column</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student.</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<ReportCard> GetReportCardByKey(int? educationOrganizationId, DateTime? gradingPeriodBeginDate, string gradingPeriodDescriptor, int? schoolId, string studentUniqueId, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/reportCards", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (educationOrganizationId == null || gradingPeriodBeginDate == null || gradingPeriodDescriptor == null || schoolId == null || studentUniqueId == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            if (educationOrganizationId != null)
                request.AddParameter("educationOrganizationId", educationOrganizationId);
            if (gradingPeriodBeginDate != null)
                request.AddParameter("gradingPeriodBeginDate", gradingPeriodBeginDate);
            if (gradingPeriodDescriptor != null)
                request.AddParameter("gradingPeriodDescriptor", gradingPeriodDescriptor);
            if (schoolId != null)
                request.AddParameter("schoolId", schoolId);
            if (studentUniqueId != null)
                request.AddParameter("studentUniqueId", studentUniqueId);
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<ReportCard>(request);

            return response;
        }
        /// <summary>
        /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this is often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
        /// </summary>
        /// <param name="body">The JSON representation of the &quot;reportCard&quot; resource to be created or updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PostReportCards(ReportCard body) 
        {
            var request = new RestRequest("/reportCards", Method.POST);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddBody(body);
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json";
            var response = client.Execute(request);

            var location = response.Headers.FirstOrDefault(x => x.Name == "Location");

            if (location != null && !string.IsNullOrWhiteSpace(location.Value.ToString()))
                body.id = location.Value.ToString().Split('/').Last();
            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the resource's identifier (using the &quot;Get By Id&quot; pattern). This GET operation retrieves a resource by the specified resource identifier.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be retrieved.</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<ReportCard> GetReportCardsById(string id, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/reportCards/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<ReportCard>(request);

            return response;
        }
        /// <summary>
        /// Updates or creates a resource based on the resource identifier. The PUT operation is used to update or create a resource by identifier.  If the resource doesn't exist, the resource will be created using that identifier.  Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be updated.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
        /// <param name="body">The JSON representation of the &quot;reportCard&quot; resource to be updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PutReportCard(string id, string IfMatch, ReportCard body) 
        {
            var request = new RestRequest("/reportCards/{id}", Method.PUT);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null || body == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-Match", IfMatch);
            request.AddBody(body);
            request.Parameters.First(param => param.Type == ParameterType.RequestBody).Name = "application/json";
            var response = client.Execute(request);

            var location = response.Headers.FirstOrDefault(x => x.Name == "Location");

            if (location != null && !string.IsNullOrWhiteSpace(location.Value.ToString()))
                body.id = location.Value.ToString().Split('/').Last();
            return response;
        }
        /// <summary>
        /// Deletes an existing resource using the resource identifier. The DELETE operation is used to delete an existing resource by identifier.  If the resource doesn't exist, an error will result (the resource will not be found).
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be deleted.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the DELETE from removing a resource modified by another consumer.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse DeleteReportCardById(string id, string IfMatch= null) 
        {
            var request = new RestRequest("/reportCards/{id}", Method.DELETE);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-Match", IfMatch);
            var response = client.Execute(request);

            return response;
        }
        }
    }

