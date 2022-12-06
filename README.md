# Structures

During leaning task was created 4 structures: Article, Client, Request and RequestItem with filds and properties.

Added a folder Enums, that includes 3 enums: ArticleType, ClientType and PayType. Also added a fields with this 
enums by an Article, Client and Request classes.

An elementary scheme of the functioning of delegates is being implemented:
There is a Vector class into which an array of integers is passed. 
The user can pass a numerical operation (for example, the sum of elements or their product). 
The action is executed and the result is returned.

Created a Person class containing the name and surname fields, decorated with properties, also a class containing the collection of Persons 
- Peoples class. The Peoples class has an option for filling the collection - the Add method. Also, the Peoples class has a guider field 
decorated with a property. When a Person is added to the collection that has the same Surname as the Guider, the SameSurname Event is activated, 
which sends the message to user about it.
A subclass from the Person class - StrongCompany - with similar event processing logic is also implemented.

Added Demo class with methods for finding the maximum and minimum value in a collection of integers.
Implemented a delegate that returns the maximum integer value in a collection.

Added some classes for learn delegates, events and lambda-expressions.