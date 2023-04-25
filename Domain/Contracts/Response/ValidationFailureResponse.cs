using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts.Response
{

    public class ValidationFailureResponse
    {
        public IEnumerable<ValidationResponse> Errors { get; init; }
    }

    public class ValidationResponse
    {
        public string PropertyName { get; init; }
        public string Message { get; init; }
    }
}
