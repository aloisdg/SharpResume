# SharpResume
SharpResume is a C# PCL for [JSONResume](https://jsonresume.org/). JSONResume is Open Source. You can find the project on [GitHub](https://github.com/jsonresume/resume-schema).

## Difference with JSONResume

* Language's property "language" is renamed "Name".
* Reference's property "reference" is renamed "Comment".
* All *Date are called * and I change their type from `string` to `DateTime`.
  * Award's Date keeps his name.
