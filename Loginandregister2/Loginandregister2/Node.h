#ifndef NODE_H
#define NODE_H


//*******************************************************************************************************

template <typename T>
class Node
{
	public:

		T data;
		Node<T> * next;
		Node();
		Node(const T&, Node<T> * = nullptr, Node<T> * = nullptr);
};

//*******************************************************************************************************

template <typename T>
Node<T>::Node()
{
	next = nullptr;
}

//*******************************************************************************************************

template <typename T>
Node<T>::Node(const T& d, Node<T> * n, Node<T> * p)
{
	data = d;
	next = n;
}
#endif
