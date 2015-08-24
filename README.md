# SharpResume
SharpResume is a C# PCL for [JSONResume](https://jsonresume.org/). JSONResume defines itself as:

> The open source initiative to create a JSON-based standard for resumes. For developers, by developers.

You can find the project JSONResume on [GitHub](https://github.com/jsonresume/resume-schema).

Get the last release of SharpResume on [NuGet](https://www.nuget.org/packages/SharpResume/) or on [GitHub](https://github.com/aloisdg/SharpResume/releases).

## Demo

[![Demo SharpResume](http://i.imgur.com/Wq1d83v.png)](http://i.imgur.com/Wq1d83v.png)

## Support

|             | Basics | Works | Volunteers | Educations | Awards | Publications | Skills | Languages | Interests | References |
| ----------- |:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| SharpResume |  x  |  x  |  x  |  x  |  x  |  x  |  x  |  x  |  x  |  x  |

_[learn more](https://jsonresume.org/schema/)_

## Difference with JSONResume

* Language's property "language" is renamed "Name".
* Reference's property "reference" is renamed "Comment".
* All *Date are called * and I change their type from `string` to `DateTime`.
  * Award's Date keeps his name.

## Feature Done v0.2.1

_soon ..._

## Bug Reports & Feature Requests

You can help by reporting bugs, suggesting features, reviewing feature specifications or just by sharing your opinion.

Use [GitHub Issues](https://github.com/aloisdg/SharpResume/issues) for all of that.

## Contributing

0. Talk about your feature on [issues](https://github.com/aloisdg/SharpResume/issues).
1. [Fork the project](https://help.github.com/articles/fork-a-repo/).
2. Create a branch for your awesome feature.
3. Write tests.
4. Write code to make the tests pass.
5. [Submit a pull request](https://help.github.com/articles/creating-a-pull-request/).

All pull requests are welcome!

## License

SharpResume uses the MIT license. See [LICENSE](https://github.com/aloisdg/SharpResume/blob/master/License) for more details.

## Misc

You way want to check this projects:

- [sharpresume](https://code.google.com/p/sharpresume/) - #Résumé is a C# implementation of the HR-XML Consortium's standard resume. [mirror](https://github.com/elevate/sharpresume)
- [ResumeSharp](https://resumesharp.codeplex.com/) - ResumeSharp is a resume building tool designed to help keep your resume up-to-date easily. Additionally, you can quickly generate targeted resumes on the fly.
