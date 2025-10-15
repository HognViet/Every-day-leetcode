#include <iostream>
#include "Node.h"

#include <List>
void printNode( Node* head);
Node* RemoveNode(Node* head, int val);
Node* RemoveFirstNode(Node* head);
Node* AddNode(Node* head, int index, int val);
Node* ReverseNode(Node* head);
int main() {
    Node* node = new Node(1);
    Node* node1 = new Node(2);
    Node* node2 = new Node(3);
    Node* node3 = new Node(4);
    Node* node4 = new Node(5);

    node->next = node1;
    node1->next = node2;
    node2->next = node3;
    node3->next = node4;
    node4->next = nullptr;
    node = ReverseNode(node);
    printNode(node);
    // RemoveNode(node,3);
    // RemoveFirstNode(node);
    // AddNode(node, 2, 6);
    // printNode(node);
    delete node;
    delete node1;
    delete node2;
    delete node3;
    delete node4;
    return 0;

}
void printNode( Node* head) {
    if ( head == nullptr ) return;
    while ( head != nullptr ) {
        std::cout << head->val;
        if (head->next != nullptr) {
            std::cout << "->";
        }
        head = head->next;
    }
}
Node* RemoveNode(Node* head, int val) {
    if (head == nullptr) return nullptr;
    while (head && head->val == val) {
        Node* temp = head;
        head = head->next;
        delete temp;
    }
    Node* current = head;
    while (current && current->next) {
        if (current->next->val == val) {
            Node* temp = current->next;
            current->next = current->next->next;
            delete temp;
        } else {
            current = current->next;
        }
    }
    return head;
}

Node* RemoveFirstNode(Node* head) {
    if (head == nullptr) return nullptr;
    Node* temp = head;
    head = head->next;
    delete temp;
    return head;
}

Node* AddNode(Node *head, int index, int val) {
    if ( head == nullptr ) return nullptr;
    Node *current = head;
    int pos = 0;
    while (current->next != nullptr) {
        if (pos +1 == index ) {
            Node* temp = new Node(val);
            temp->next = current->next;
            current->next = temp;
            return head;
        }else {
            pos++;
            current = current->next;
        }
    }
    return head;
}
Node* ReverseNode(Node* head) {
    // if (head == nullptr || head->next == nullptr)
    //     return head;

    // Node* current = head;
    // Node* reverse = nullptr;
    // while (current->next != nullptr) {
    //     reverse = current->next;
    //     current->next = reverse->next;
    //     reverse->next = head;
    //     head = reverse;
    // }
    if (head == nullptr) return nullptr;
    Node* current = head->next;
    if ( current == nullptr ) return head;
    Node* reverse = ReverseNode(current);
    current->next = head;
    head->next = nullptr;

    return reverse;
}




