# Card Game Demo 1

In this video, we are going to start building the card game.  I have provided a starter solution.  This solution has 2 projects

The first project is a Class library project called BOLayer (which stands for business object layer).  It will contain all of the classes we will use in our application.  Currently, we have a Card.cs file which contains a stub for our card class which we will build in this video.  There is also a Types.cs file where we will put the enums we will create

The other project is a Windows Forms project.  With this project, we won't be building a full card game, but we will be building some functionality that will be useful to you when you build your own card game.  Notice inside this project, there is an images folder, and it contains image files for all of the cards  in a deck of cards.  The naming convention of the file is FaceValueSuit.jpg

Here is the class diagram that shows what we will be building.  We will be building a Card class.  A card will have 2 properties.   A FaceValue and Suit.  We will create enums for the data types of these properties.  The card class will have 1 constructor, what accepts a suite and a facevalue.

Lets begin in the Types.cs file of our BOLayer class library, and create enums for FaceValue and Suit.

Now that we have those create, let's go create the properties in the card class

Now that we have our class built, let's write a unit test.  First we need to create a unit test project

I'm going to test the constructor

Now, let's open up our form.  When the button is clicked, we will display a random card in this panel.

Let's first create a method that will generate a random card for us.  .NET has a built in class called Random that allows us to generate random numbers.  For the suit, we will generate a random number between 0 and 3...since there are 4 suits, and the index of the suit in the enum begins at zero.  And for the face value, we will generate a number between 0 and 12, since there are 13 face values and the face value enum index begins at zero.

Now that we have that method created, let's create a method that will display the card.  We will call it ShowCard, with no return value, and it will accept the card to show as a parameter

Remember that the images are stored in the format facevaluesuitname.jpg.  Let's first get the face value name and suite name from the car that is being passed in.

Then we can create  variable to store the path of the image for that card.

We will display the card inside the panel on our form.  We need to first put that image inside a PictureBox control.  We will dynamically create the picture box control.  And now, let's add that picture box control to the panels collection of controls.

Up at the top of this method, let's remove all of the controls from the panel so that the panel is clear before we add the card to it.



