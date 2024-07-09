using Journey.Communication.Requests;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripUseCase
    {
        public void Execute(RequestRegisterTripJson request)
        {
            Validate(request);
        }

        private void Validate(RequestRegisterTripJson request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                throw new JouneyException(ResourceErrorMessages.NAME_EMPTY);
            }

            if(request.StartDate.Date < DateTime.UtcNow.Date)
            {
                throw new JouneyException(ResourceErrorMessages.START_DATE_TRIP_MUST_BE_LATER_THAN_TODAY);
            }

            if (request.EndDate.Date < request.StartDate.Date)
            {
                throw new JouneyException(ResourceErrorMessages.END_DATE_TRIP_MUST_BE_LATER_THAN_START_DATE);
            }
        }
    }
}
