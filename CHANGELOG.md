# Changelog

## [Unreleased]

## [1.0.10] - 2024-04-03
### Added
- Added GitHub Actions Workflow files to be shared in several projects.
- Added Google Sheet Exporter.

## [1.0.9] - 2024-01-01
### Added
- Added MinOrMinusOne(this IEnumerable<int> sequence) for  IEnumerable<int>.
- Added optionalDependencies to project settings.

## [1.0.8] - 2023-05-22
### Changed
- Fixed AddNameSpace to support Unity 2022.2.x and Windows.

## [1.0.7] - 2022-12-05
### Changed
- Fixed RandomWeightedElementAt<T>.

## [1.0.6] - 2022-05-08
### Added
- Added RandomWeightedElementAt<T>(this IEnumerable<T> ie, Func<T, float> weightSelector) for IEnumerable<T>.

## [1.0.5] - 2022-04-10
### Added
- Added Shuffle() for IList<T>.

## [1.0.4] - 2022-01-18
### Added
- Created LinqExtension and ObservableExtension to check the stream using Debug.Log().  To use them, you need to import NewtonSoft.Json package and (only for ObservableExtension,) UniRx.
### Changed
- Even when DictionaryExtension gets null as key, it returns default value.
- Updated to Unity Editor 2021.2.7f1.

## [1.0.3] - 2021-11-28
### Added
- Created EnumerableExtension.
### Changed
- Updated to Unity Editor 2021.2.3f1.

## [1.0.2] - 2021-10-28
### Removed
- Delete package-lock.json.

## [1.0.1] - 2021-10-28
### Changed
- Removed Unity. from the name of asmdefs.

## [1.0.0] - 2021-10-28
### Added
- Start distribution from Unity Package Manager.

[Unreleased]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.8...HEAD
[1.0.8]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.7...v1.0.8
[1.0.7]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.6...v1.0.7
[1.0.6]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.5...v1.0.6
[1.0.5]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.4...v1.0.5
[1.0.4]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.3...v1.0.4
[1.0.3]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.2...v1.0.3
[1.0.2]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.1...v1.0.2
[1.0.1]: https://github.com/shirokurohitsuji/UnityUtilities/compare/v1.0.0...v1.0.1
[1.0.0]: https://github.com/shirokurohitsuji/UnityUtilities/releases/tag/v1.0.0
