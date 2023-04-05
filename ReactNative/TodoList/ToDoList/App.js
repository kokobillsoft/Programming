import { StatusBar } from 'expo-status-bar';
import { Alert, StyleSheet, Text, View, FlatList, TouchableHighlight, KeyboardAvoidingView, Platform } from 'react-native';
import Header from './components/Header';
import ListItem from './components/ListItem';
import Form from './components/Form';
import React, {useState} from 'react';
import Swipeable from 'react-native-gesture-handler/Swipeable';

export default function App() {
  const [listOfItems, setListOfItems] = useState([
    {text: 'Buy Milk', key: 1},
  ]);



  const addHandler = (inputTextForList) => {
    if (inputTextForList == ""){
      Alert.alert("Wrong input",  "Add text for Item", [
        {text: "Ok"},
        {text: "Exit"},
      ]);
    }
    else{
      setListOfItems((list) => {
        return [
          { text:inputTextForList, key: Math.random().toString(36).substring(7)},
          ...list
        ];
      });
    }
    
  };

  const deleteHandler = (key) => {
    setListOfItems((list) => {
      return list.filter(listOfItems => listOfItems.key != key);
    });
  };

  return (

    <View style={styles.container}>
      <Header />
      <Form addHandler={addHandler}/> 
      <KeyboardAvoidingView behavior={Platform.OS == "ios" ? "padding" : "height"}>
      <View>
        <FlatList data = {listOfItems} renderItem = {({ item }) => (
          <ListItem el={item} deleteHandler={deleteHandler}/>
        )}/>
      </View>
      </KeyboardAvoidingView>
    </View>
    
  );
}

const styles = StyleSheet.create({
  
});
