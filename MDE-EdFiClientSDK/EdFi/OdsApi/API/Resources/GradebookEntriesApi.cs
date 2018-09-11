using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.OdsApi.Sdk;
using EdFi.OdsApi.Models.Resources;
using RestSharp;
  
namespace EdFi.OdsApi.Api.Resources 
{
    public class GradebookEntriesApi 
    {
        private readonly IRestClient client;

        public GradebookEntriesApi(IRestClient client)
        {
            this.client = client;
        }
      
        /// <summary>
        /// Retrieves resources based with paging capabilities (using the &quot;Get All&quot; pattern). This GET operation provides access to resources using the &quot;Get All&quot; pattern. In this version of the API there is support for paging.
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<GradebookEntry>> GetGradebookEntriesAll(int? offset= null, int? limit= null) 
        {
            var request = new RestRequest("/gradebookEntries", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<GradebookEntry>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves resources matching values of an example resource (using the &quot;Get By Example&quot; pattern). This GET operation provides access to resources using the &quot;Get by Example&quot; search pattern.  The values of any properties of the resource that are specified will be used to return all matching results (if it exists).
        /// </summary>
        /// <param name="offset">Indicates how many items should be skipped before returning results.</param>
        /// <param name="limit">Indicates the maximum number of items that should be returned in the results (defaults to 25).</param>
        /// <param name="title">The name or title of the activity to be recorded in the gradebook entry.</param>
        /// <param name="dateAssigned">The date the assignment, homework, or assessment was assigned or executed.</param>
        /// <param name="schoolId">School Identity Column</param>
        /// <param name="classPeriodName">An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).   NEDM: Class Period</param>
        /// <param name="classroomIdentificationCode">A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.</param>
        /// <param name="localCourseCode">The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students.</param>
        /// <param name="termDescriptor">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="schoolYear">The identifier for the school year.</param>
        /// <param name="uniqueSectionCode">A unique identifier for the section, that is defined for a campus by the classroom, the subjects taught, and the instructors that are assigned.  NEDM: Unique Course Code</param>
        /// <param name="sequenceOfCourse">When a section is part of a sequence of parts for a course, the number if the sequence.  If the course has only onle part, the value of this section attribute should be 1.</param>
        /// <param name="gradingPeriodDescriptor">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="beginDate">Month, day, and year of the first day of the grading period.</param>
        /// <param name="type">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="description">A detailed description of the entity.</param>
        /// <param name="id"></param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<List<GradebookEntry>> GetGradebookEntriesByExample(int? offset= null, int? limit= null, string title= null, DateTime? dateAssigned= null, int? schoolId= null, string classPeriodName= null, string classroomIdentificationCode= null, string localCourseCode= null, string termDescriptor= null, int? schoolYear= null, string uniqueSectionCode= null, int? sequenceOfCourse= null, string gradingPeriodDescriptor= null, DateTime? beginDate= null, string type= null, string description= null, string id= null) 
        {
            var request = new RestRequest("/gradebookEntries", Method.GET);
            request.RequestFormat = DataFormat.Json;

            if (offset != null)
                request.AddParameter("offset", offset);
            if (limit != null)
                request.AddParameter("limit", limit);
            if (title != null)
                request.AddParameter("title", title);
            if (dateAssigned != null)
                request.AddParameter("dateAssigned", dateAssigned);
            if (schoolId != null)
                request.AddParameter("schoolId", schoolId);
            if (classPeriodName != null)
                request.AddParameter("classPeriodName", classPeriodName);
            if (classroomIdentificationCode != null)
                request.AddParameter("classroomIdentificationCode", classroomIdentificationCode);
            if (localCourseCode != null)
                request.AddParameter("localCourseCode", localCourseCode);
            if (termDescriptor != null)
                request.AddParameter("termDescriptor", termDescriptor);
            if (schoolYear != null)
                request.AddParameter("schoolYear", schoolYear);
            if (uniqueSectionCode != null)
                request.AddParameter("uniqueSectionCode", uniqueSectionCode);
            if (sequenceOfCourse != null)
                request.AddParameter("sequenceOfCourse", sequenceOfCourse);
            if (gradingPeriodDescriptor != null)
                request.AddParameter("gradingPeriodDescriptor", gradingPeriodDescriptor);
            if (beginDate != null)
                request.AddParameter("beginDate", beginDate);
            if (type != null)
                request.AddParameter("type", type);
            if (description != null)
                request.AddParameter("description", description);
            if (id != null)
                request.AddParameter("id", id);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<List<GradebookEntry>>(request);

            return response;
        }
        /// <summary>
        /// Retrieves a specific resource using the values of the resource's natural key (using the &quot;Get By Key&quot; pattern). This GET operation provides access to resources using the &quot;Get by Key&quot; search pattern. The values of the natural key of the resource must be fully specified, and the service will return the matching result (if it exists).
        /// </summary>
        /// <param name="classPeriodName">An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).   NEDM: Class Period</param>
        /// <param name="classroomIdentificationCode">A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.</param>
        /// <param name="dateAssigned">The date the assignment, homework, or assessment was assigned or executed.</param>
        /// <param name="title">The name or title of the activity to be recorded in the gradebook entry.</param>
        /// <param name="localCourseCode">The local code assigned by the LEA or Campus that identifies the organization of subject matter and related learning experiences provided for the instruction of students.</param>
        /// <param name="schoolId">School Identity Column</param>
        /// <param name="schoolYear">The identifier for the school year.</param>
        /// <param name="sequenceOfCourse">When a section is part of a sequence of parts for a course, the number if the sequence.  If the course has only onle part, the value of this section attribute should be 1.</param>
        /// <param name="termDescriptor">A unique identifier used as Primary Key, not derived from business logic, when acting as Foreign Key, references the parent table.</param>
        /// <param name="uniqueSectionCode">A unique identifier for the section, that is defined for a campus by the classroom, the subjects taught, and the instructors that are assigned.  NEDM: Unique Course Code</param>
        /// <param name="IfNoneMatch">The previously returned ETag header value, used here to prevent the unnecessary data transfer of an unchanged resource.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse<GradebookEntry> GetGradebookEntryByKey(string classPeriodName, string classroomIdentificationCode, DateTime? dateAssigned, string title, string localCourseCode, int? schoolId, int? schoolYear, int? sequenceOfCourse, string termDescriptor, string uniqueSectionCode, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/gradebookEntries", Method.GET);
            request.RequestFormat = DataFormat.Json;

            // verify required params are set
            if (classPeriodName == null || classroomIdentificationCode == null || dateAssigned == null || title == null || localCourseCode == null || schoolId == null || schoolYear == null || sequenceOfCourse == null || termDescriptor == null || uniqueSectionCode == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            if (classPeriodName != null)
                request.AddParameter("classPeriodName", classPeriodName);
            if (classroomIdentificationCode != null)
                request.AddParameter("classroomIdentificationCode", classroomIdentificationCode);
            if (dateAssigned != null)
                request.AddParameter("dateAssigned", dateAssigned);
            if (title != null)
                request.AddParameter("title", title);
            if (localCourseCode != null)
                request.AddParameter("localCourseCode", localCourseCode);
            if (schoolId != null)
                request.AddParameter("schoolId", schoolId);
            if (schoolYear != null)
                request.AddParameter("schoolYear", schoolYear);
            if (sequenceOfCourse != null)
                request.AddParameter("sequenceOfCourse", sequenceOfCourse);
            if (termDescriptor != null)
                request.AddParameter("termDescriptor", termDescriptor);
            if (uniqueSectionCode != null)
                request.AddParameter("uniqueSectionCode", uniqueSectionCode);
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<GradebookEntry>(request);

            return response;
        }
        /// <summary>
        /// Creates or updates resources based on the natural key values of the supplied resource. The POST operation can be used to create or update resources. In database terms, this is often referred to as an &quot;upsert&quot; operation (insert + update).  Clients should NOT include the resource &quot;id&quot; in the JSON body because it will result in an error (you must use a PUT operation to update a resource by &quot;id&quot;). The web service will identify whether the resource already exists based on the natural key values provided, and update or create the resource appropriately.
        /// </summary>
        /// <param name="body">The JSON representation of the &quot;gradebookEntry&quot; resource to be created or updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PostGradebookEntries(GradebookEntry body) 
        {
            var request = new RestRequest("/gradebookEntries", Method.POST);
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
        public IRestResponse<GradebookEntry> GetGradebookEntriesById(string id, string IfNoneMatch= null) 
        {
            var request = new RestRequest("/gradebookEntries/{id}", Method.GET);
            request.RequestFormat = DataFormat.Json;

            request.AddUrlSegment("id", id);
            // verify required params are set
            if (id == null ) 
               throw new ArgumentException("API method call is missing required parameters");
            request.AddHeader("If-None-Match", IfNoneMatch);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute<GradebookEntry>(request);

            return response;
        }
        /// <summary>
        /// Updates or creates a resource based on the resource identifier. The PUT operation is used to update or create a resource by identifier.  If the resource doesn't exist, the resource will be created using that identifier.  Additionally, natural key values cannot be changed using this operation, and will not be modified in the database.  If the resource &quot;id&quot; is provided in the JSON body, it will be ignored as well.
        /// </summary>
        /// <param name="id">A resource identifier specifying the resource to be updated.</param>
        /// <param name="IfMatch">The ETag header value used to prevent the PUT from updating a resource modified by another consumer.</param>
        /// <param name="body">The JSON representation of the &quot;gradebookEntry&quot; resource to be updated.</param>
        /// <returns>A RestSharp <see cref="IRestResponse"/> instance containing the API response details.</returns>
        public IRestResponse PutGradebookEntry(string id, string IfMatch, GradebookEntry body) 
        {
            var request = new RestRequest("/gradebookEntries/{id}", Method.PUT);
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
        public IRestResponse DeleteGradebookEntryById(string id, string IfMatch= null) 
        {
            var request = new RestRequest("/gradebookEntries/{id}", Method.DELETE);
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

