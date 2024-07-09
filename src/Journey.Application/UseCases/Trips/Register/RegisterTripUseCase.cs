using Journey.Communication.Requests;

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
                throw new ArgumentException("Nome não é pode ser vazio.");
            }

            if(request.StartDate.Date < DateTime.UtcNow.Date)
            {
                throw new ArgumentException("A viagem não pode ser registrada para uma data passada.");
            }

            if (request.EndDate.Date < request.StartDate.Date)
            {
                throw new ArgumentException("A data final não pode ser menor que a data inicial.");
            }
        }
    }
}
