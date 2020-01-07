public class ForwardList<T>
{
	public ForwardList()
	{
		head = tail = null;
	}

	public virtual void insertAtHead(T data)
	{
		Node<T> n = new Node<T>(data, head);
		head = n;
		if (tail == null)
		{
			tail = n;
		}
	}

	public virtual bool isEmpty
	{
		get
		{
			return head == null;
		}
	}

	public virtual Node<T> findFirst(T data)
	{
		Node<T> currentNode = head;
		while (currentNode != null)
		{
			if (currentNode.data == data)
			{
				return currentNode;
			}
			currentNode = currentNode.next;
		}
		return null;
	}

	public virtual void removeAtHead()
	{
		if (isEmpty)
		{
			throw new NoSuchElementException("List empty! Cannot remove from head!");
		}

		head = head.next;
		if (head == null)
		{
			tail = null;
		}
	}

	public virtual void removeAtTail()
	{
		if (isEmpty)
		{
			throw new NoSuchElementException("List empty! Cannot remove from tail!");
		}

		if (head == tail)
		{
			head = tail = null;
			return;
		}

		Node<T> currentNode = head;
		while (currentNode.next != tail)
		{
			currentNode = currentNode.next;
		}
		currentNode.next = null;
		tail = currentNode;
	}

	internal Node<T> head;
	internal Node<T> tail;
}

public class Node<T>
{
	public Node(T data, Node<T> next)
	{
		this.data = data;
		this.next = next;
	}

	internal T data;
	internal Node<T> next;
}