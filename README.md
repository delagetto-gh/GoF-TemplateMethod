## [GoF Patterns]

#### Template Method:

*Defintition:*
> "Defer the exact steps of an algorithm to a subclass"

---

*Description of example code:*

We need a base class that has all the information... and then we need subclasses that carry specific information which the base needs the derived to handle. It's all about making the class with the **most** information do **most** of the work, and delegate to the ***derived*** when needed.

Our base is:
```cs 
abstract class LanguageSpeakingHuman.cs 
```
which has almost all the info and behaviour we need -  
- A name (*field*)
- The ability to speak (*behavior*)

---

We want our language speaking human to say
> "Hello, my name is [name]!" 

All in their native languages. We could have our Base class contain a list of all "hello.." translations in each laguage, but that is combersone and violates the Open/Closed principle - if we need a new language translation, we have to **modify** the base.

So we have derived Language Speaking Humans - one for each language we need.

Base 
```cs 
LanguageSpeakingHuman.cs
``` 
will do grunt work of preparing the full sentance, with their name... while *derived* **LanguageSpeakingHumans** will prepare the part of the sentance that is specific to it (what the base must delegate for).


