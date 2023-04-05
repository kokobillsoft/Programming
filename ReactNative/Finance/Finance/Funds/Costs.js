import React, { useEffect, useState } from "react";
import { Text, View, SafeAreaView } from 'react-native';
import { FlatList, ScrollView } from "react-native-gesture-handler";
import { set } from "react-native-reanimated";

export default function Costs() {

    const [costsArray, setCostsArray] = useState([]);
    const [isLoading, setIsLoading] = useState (false);
    
    const renderItemList = ({item}) => (
        <Text>{item.id} - {item.title}</Text>
    )

    useEffect(()=>{
        getPosts();
    },[])

    const getPosts = () => {
        setIsLoading(true);
        let URL = 'https://jsonplaceholder.typicode.com/posts'
        fetch(URL).then(res => res.json()).then(res => {
            setCostsArray(res);
        }).finally(()=>{setIsLoading(true)})
    }
    return(
        <SafeAreaView>
            <FlatList 
            data={costsArray} 
            renderItem={renderItemList}
            keyExtractor={item => item.id}
            onRefresh={getPosts}
            refreshing={isLoading}
            />
        </SafeAreaView>
    );
}