using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using Core.Configuration;
using Core.Helpers;
using Core.Logger;
using EuromoneyAPI.UserService;

namespace UserHelper
{
	public class UserManager
	{
		public UserDTO GenerateUserDetails()
		{
			var userCountry = new CountryDTO()
			{
				IsoCode = "PL",
				Name = "Poland"
			};

			var userAddress = new UserAddressDTO()
			{
				Address1 = "Name_" + BasicHelper.GenerateRandomNumberString(4),
				City = "City_" + BasicHelper.GenerateRandomNumberString(4),
				PostCode = "12345",
				Country = userCountry
			};

			var userDetails = new UserDTO()
			{
				UserName = "Testing",
				Forename = "Tester",
				Surname = "Test",
				CompanyName = "FP",
				DisplayName = "testUser_" + BasicHelper.GenerateRandomNumberString(4),
				EmailAddress = "testuser" + BasicHelper.GenerateRandomNumberString(4) + "@automation.test",
				PhoneNumber = BasicHelper.GenerateRandomNumberString(9),
				SubscriberType = EnumsSubscriberType.Registrant,
				UserAddress = userAddress
			};
			return userDetails;
		}

		public UserDTO CreateUser()
		{
			UserServiceSoapClient service = new UserServiceSoapClient("UserServiceSoap");
			ResultDTOOfConsumerLogonRequestDTO consumer = service.ConsumerLogin(ApplicationConfiguration.ConsumerId, ApplicationConfiguration.ConsumerPassword);
			Logger.Info(service.State.ToString());

			UserDTO user = new UserDTO();
			user = GenerateUserDetails();

			ResultDTOOfNewUserAccountResponseDTO result = service.CreateUser(consumer.Result.Token.ToString(), user);
			foreach (var error in result.ParamErrors)
			{
				Logger.Info(error.ParamName);
				Logger.Info(error.ErrorType.ToString());
				Logger.Info(error.Message);
			}

			Logger.Info(result.Status.ToString());
			user.UserId = result.Result.UserId;

			return user;
		}

		public void SendPassword(string emailAddress)
		{
			UserServiceSoapClient service = new UserServiceSoapClient("UserServiceSoap");
			ResultDTOOfConsumerLogonRequestDTO consumer = service.ConsumerLogin(ApplicationConfiguration.ConsumerId, ApplicationConfiguration.ConsumerPassword);

			service.SendPasswordReminder(consumer.Result.Token.ToString(), emailAddress);
		}
	}
}
