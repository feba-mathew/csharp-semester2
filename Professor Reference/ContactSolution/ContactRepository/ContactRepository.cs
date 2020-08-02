using ContactDB;
using ContactRepository.Models;
using System.Collections.Generic;
using System.Linq;

// This project/namespace maps to the Database Contacts
namespace ContactRepository
{

    public class ContactRepository // Maps to the database table Contact
    {
        public ContactModel Add(ContactModel contactModel)
        {
            var contactDb = ToDbModel(contactModel);

            DatabaseManager.Instance.Contact.Add(contactDb);
            DatabaseManager.Instance.SaveChanges();

            contactModel = new ContactModel
            {
                Age = contactDb.ContactAge,
                CreatedDate = contactDb.ContactCreatedDate,
                Email = contactDb.ContactEmail,
                Id = contactDb.ContactId,
                Name = contactDb.ContactName,
                Notes = contactDb.ContactNotes,
                PhoneNumber = contactDb.ContactPhoneNumber,
                PhoneType = contactDb.ContactPhoneType
            };
            return contactModel;
        }

        public List<ContactModel> GetAll()
        {
            // Use .Select() to map the database contacts to ContactModel
            var items = DatabaseManager.Instance.Contact
              .Select(t => new ContactModel
              {
                  Age = t.ContactAge,
                  CreatedDate = t.ContactCreatedDate,
                  Email = t.ContactEmail,
                  Id = t.ContactId,
                  Name = t.ContactName,
                  Notes = t.ContactNotes,
                  PhoneNumber = t.ContactPhoneNumber,
                  PhoneType = t.ContactPhoneType,
              }).ToList();

            return items;
        }

        public bool Update(ContactModel contactModel)
        {
            var original = DatabaseManager.Instance.Contact.Find(contactModel.Id);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(contactModel));
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Remove(int contactId)
        {
            var items = DatabaseManager.Instance.Contact
                                .Where(t => t.ContactId == contactId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Contact.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private Contact ToDbModel(ContactModel contactModel)
        {
            var contactDb = new Contact
            {
                ContactAge = contactModel.Age,
                ContactCreatedDate = contactModel.CreatedDate,
                ContactEmail = contactModel.Email,
                ContactId = contactModel.Id,
                ContactName = contactModel.Name,
                ContactNotes = contactModel.Notes,
                ContactPhoneNumber = contactModel.PhoneNumber,
                ContactPhoneType = contactModel.PhoneType,
            };

            return contactDb;
        }
    }
}
