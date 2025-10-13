//
// Created by Viet on 10/9/2025.
//

#ifndef NODE_H
#define NODE_H

struct Node {
    int val;
    Node* next;
    Node(int val) : val(val), next(nullptr) {}
};

#endif //NODE_H
