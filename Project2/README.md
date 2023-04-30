### Project2 - (HashSet and SortedSet classes)

:arrow_right: __HashSet__

* Hash table storage
* Extremely fast : insertion, removal and search O(1).
* Elements order is not assured

:arrow_right: __SortedSet__

* Tree storage.
* Fast : insertion, removal and search O(log(n))
* Elements stored in order according to IComparer<T> implementation.


:arrow_right: __How hash collections test equality?__

__*if GetHashCode and Equals methods are implemented:*__ 

-> First HashCode. If it's the same, it is confirmed with equals method
              
__*if GetHashCode and Equals methods are NOT implemented:*__

-> Reference types: object references are compared.

-> Value types : attributes values are compared.