using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.Models
{
   public class FakeDb
   {
      //Fields
      private static UserResponse[] responses = new UserResponse[2];
      private static int responseCount = 0;
      
      //Constructors

      //Methods
      //CRUD :Create
      public static void AddResponse(UserResponse response)
      {
         responses[responseCount] = response;
         responseCount++;
      }//end AddResponse()
       //CRUD : READ
  
      public static UserResponse[] GetResponses()
      {
         return responses;
      }
   }
}
