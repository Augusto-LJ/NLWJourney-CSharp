﻿using Journey.Communication.Requests;
using Journey.Communication.Responses;
using Journey.Exception;
using Journey.Exception.ExceptionsBase;
using Journey.Infrastructure;
using Journey.Infrastructure.Entities;

namespace Journey.Application.UseCases.Trips.Register
{
    public class RegisterTripUseCase
    {
        public ResponseShortTripJson Execute(RequestRegisterTripJson request)
        {
            Validate(request);

            var dbContext = new JourneyDbContext();

            var entity = new Trip
            {
                Name = request.Name,
                StartDate = request.StartDate,
                EndDate = request.EndDate
            };

            dbContext.Trips.Add(entity);

            dbContext.SaveChanges();

            return new ResponseShortTripJson
            {
                Name = entity.Name,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Id = entity.Id
            };
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
